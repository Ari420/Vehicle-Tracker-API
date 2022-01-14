using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using VehicleTrackingApi.Models;

namespace VehicleTrackingApi.Controllers
{
    public class VehicleDevicesController : ApiController
    {
        private DBConnection db = new DBConnection();

        // GET: api/VehicleDevices
        public IQueryable<VehicleDevice> GetVehicleDevices()
        {
            return db.VehicleDevices;
        }

        // GET: api/VehicleDevices/5
        [ResponseType(typeof(VehicleDevice))]
        public async Task<IHttpActionResult> GetVehicleDevice(int id)
        {
            VehicleDevice vehicleDevice = await db.VehicleDevices.FindAsync(id);
            if (vehicleDevice == null)
            {
                return NotFound();
            }

            return Ok(vehicleDevice);
        }

        // PUT: api/VehicleDevices/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVehicleDevice(int id, VehicleDevice vehicleDevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicleDevice.DeviceId)
            {
                return BadRequest();
            }

            db.Entry(vehicleDevice).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleDeviceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VehicleDevices
        [ResponseType(typeof(VehicleDevice))]
        public async Task<IHttpActionResult> PostVehicleDevice(VehicleDevice vehicleDevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VehicleDevices.Add(vehicleDevice);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vehicleDevice.DeviceId }, vehicleDevice);
        }

        // DELETE: api/VehicleDevices/5
        [ResponseType(typeof(VehicleDevice))]
        public async Task<IHttpActionResult> DeleteVehicleDevice(int id)
        {
            VehicleDevice vehicleDevice = await db.VehicleDevices.FindAsync(id);
            if (vehicleDevice == null)
            {
                return NotFound();
            }

            db.VehicleDevices.Remove(vehicleDevice);
            await db.SaveChangesAsync();

            return Ok(vehicleDevice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleDeviceExists(int id)
        {
            return db.VehicleDevices.Count(e => e.DeviceId == id) > 0;
        }
    }
}