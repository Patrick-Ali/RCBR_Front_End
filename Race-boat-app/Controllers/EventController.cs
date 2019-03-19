using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Race_boat_app.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Race_boat_app.Controllers
{
    public class EventController : Controller
    {
        static HttpClient client = new HttpClient();

        public async Task<IActionResult> All()
        {
            List<EventReg> eventRegs = await GetEventRegsAsync("https://localhost:44389/api/1.0/eventReg");
            ViewData["eventRegs"] = eventRegs;
            return View("Events");
        }

        public IActionResult RegisterEvent()
        {
            return View("EventRegister");
        }

        [HttpPost]
        public async Task<IActionResult> ViewEvent(String id)
        {
            EventIn event1 = await GetEventAsync("https://localhost:44389/api/1.0/event/"+id);
            return RedirectToAction("EventRegister", event1);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterTeam(Download download)
        {
            List<EventReg> eventRegs = await GetEventRegsAsync("https://localhost:44389/api/1.0/eventReg");
            ViewData["eventRegs"] = eventRegs;
            foreach (var reg in eventRegs)
            {
                if (reg.EventID == download.Id && reg.TeamID == download.TeamId)
                {

                    return View("Events");
                }
            }
            EventReg tempReg = new EventReg()
            {
                EventID = download.Id,
                TeamID = download.TeamId
            };
            var url = await CreateEventRegAsync(tempReg);
            RedirectToAction("All");
            return View("Events");
        }

        /*public async Task<IActionResult> GetDownload(Download download) {
            string hold = download.Id;
            //await Download(hold);
            return View("Events");
        }*/

        public async Task<ActionResult> EventRegister(EventIn events)
        {//This must be an async task 
            HttpContext.Session.SetString("_VideoURL", events.VideoURL);
            HttpContext.Session.SetString("_Name", events.Name);
            HttpContext.Session.SetString("_Date", events.Date);
            HttpContext.Session.SetString("_Location", events.Location);
            HttpContext.Session.SetString("_TimeStart", events.TimeStart);
            HttpContext.Session.SetString("_TimeEnd", events.TimeEnd);
            HttpContext.Session.SetString("_Description", events.Description);
            return View("upload");
        }

        [HttpPost]
        public async Task<ActionResult> Upload()
        {
            List<EventReg> eventRegs = await GetEventRegsAsync("https://localhost:44389/api/1.0/eventReg");
            ViewData["eventRegs"] = eventRegs;
            //var test = Request.Form.Files;
            foreach (var upload in Request.Form.Files)
            {
                //if (test[0].FileName != "")
                //{

                    // read file to stream
                    Stream hold = upload.OpenReadStream();
                    byte[] array = new byte[hold.Length];
                    hold.Seek(0, SeekOrigin.Begin);
                    hold.Read(array, 0, array.Length);
                    EventIn temp = new EventIn()
                    {
                        VideoURL = HttpContext.Session.GetString("_VideoURL"),
                        Name = HttpContext.Session.GetString("_Name"),
                        Location = HttpContext.Session.GetString("_Location"),
                        Date = HttpContext.Session.GetString("_Date"),
                        TimeStart = HttpContext.Session.GetString("_TimeStart"),
                        TimeEnd = HttpContext.Session.GetString("_TimeEnd"),
                        Description = HttpContext.Session.GetString("_Description"),
                        EventFile = array
                    };
                    await CreateEventAsync(temp);
                    hold.Close();
                    return View("Events");

                //}
            }
            return View("Events");
        }

        static async Task<Uri> CreateEventAsync(EventIn eventIn)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:44389/api/1.0/event", eventIn);
            response.EnsureSuccessStatusCode();
            var tempURL = response.Headers.Location;
            Console.WriteLine(tempURL);
            return response.Headers.Location;
        }

        //[HttpGet("{id:length(24)}")]
        //public async Task<ActionResult> ViewEvent(string id)
        //{
        //    EventIn event1 = await GetEventAsync("https://localhost:44389/api/1.0/event/" + id);
        //    return View("EventView",event1);
        //}


        public async Task<List<EventIn>> AllEvents()
        {
            List<EventIn> events = await GetEventsAsync("https://localhost:44389/api/1.0/event");
            return events;
        }

        static async Task<List<EventIn>> GetEventsAsync(string path)
        {
            List<EventIn> events = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                events = await response.Content.ReadAsAsync<List<EventIn>>();
            }
            return events;
        }

    static async Task<EventIn> GetEventAsync(string path)
    {
        EventIn eventIn = null;
        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            eventIn = await response.Content.ReadAsAsync<EventIn>();
        }
        return eventIn;
    }

        public async Task<FileResult> Download(Download download)
        {
            EventIn tempEvent = await GetEventAsync("https://localhost:44389/api/1.0/event/" + download.Id);

            using (var stream = new MemoryStream())
            {
                stream.Write(tempEvent.EventFile, 0, tempEvent.EventFile.Length);
                stream.Seek(0, SeekOrigin.Begin);
                string filename = tempEvent.Name + tempEvent.Date + ".pdf";
                return File(stream.GetBuffer(), "application/pdf", filename);
            }

        }

        static async Task<Uri> CreateEventRegAsync(EventReg eventReg)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:44389/api/1.0/eventReg", eventReg);
            response.EnsureSuccessStatusCode();
            var tempURL = response.Headers.Location;
            Console.WriteLine(tempURL);
            return response.Headers.Location;
        }

        static async Task<EventReg> GetEventRegAsync(string path)
        {
            EventReg eventReg = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                eventReg = await response.Content.ReadAsAsync<EventReg>();
            }
            return eventReg;
        }

        static async Task<List<EventReg>> GetEventRegsAsync(string path)
        {
            List<EventReg> eventReg = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                eventReg = await response.Content.ReadAsAsync<List<EventReg>>();
            }
            return eventReg;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
