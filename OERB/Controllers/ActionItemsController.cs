using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.Entity;

namespace OERB.Controllers
{
    public class ActionItemsController : Controller
    {
        private ConvertedPhaseoneContext _context = new ConvertedPhaseoneContext();

        [HttpGet]
        [Route("api/ActionItems/GetAll")]
        public ActionResult GetAll()
        {
            var actionItems = _context.ActionitemActs.ToList();
            return View(actionItems);
        }

        // GET: ActionItems/Details/5
        [HttpGet]
        [Route("api/ActionItems/GetById")]
        public ActionResult GetById(int id)
        {
            var data = _context.ActionitemActs.FirstOrDefault(a => a.IdAct == id);
            return View(data);
        }

        // GET: ActionItems/PostData
        [HttpPost]
        [Route("api/ActionItems/PostData")]
        public ActionResult PostData(ActionitemAct actionitemAct)
        {
            using (DbContextTransaction transaction = (DbContextTransaction)_context.Database.BeginTransaction())
            {
                try
                {
                    _context.Add(actionitemAct);
                    _context.SaveChanges();
                    transaction.Commit();
                    return View();
                }
                catch
                {

                    transaction.Rollback();
                    return View();
                }
            }
        }
        // POST: ActionItems/PutData/5
        [HttpPut]
        [Route("api/ActionItems/PutData")]
        public ActionResult PutData(int id, ActionitemAct actionitemAct)
        {
            using (DbContextTransaction transaction = (DbContextTransaction)_context.Database.BeginTransaction())
            {
                try
                {
                    var actionItem = _context.ActionitemActs.FirstOrDefault(a => a.IdAct == id);
                    if (actionitemAct != null)
                    {
                        actionItem.NumberPrjAct = actionitemAct.NumberPrjAct;
                        actionItem.AssignedtoAct = actionitemAct.AssignedtoAct;
                        actionItem.OpenedbyAct = actionitemAct.OpenedbyAct;
                        actionItem.OpeneddateAct = actionitemAct.OpeneddateAct;
                        actionItem.StatusAct = actionitemAct.StatusAct;
                        actionItem.CategoryAct = actionitemAct.CategoryAct;
                        actionItem.PriorityAct = actionitemAct.PriorityAct;
                        actionItem.DescriptionAct = actionitemAct.DescriptionAct;
                        actionItem.FileAct = actionitemAct.FileAct;
                        actionItem.NamePrjAct = actionitemAct.NamePrjAct;
                        actionItem.ClosedateAct = actionitemAct.ClosedateAct;
                        actionItem.FilenameAct = actionitemAct.FilenameAct;
                        actionItem.IsResolvedAct = actionitemAct.IsResolvedAct;
                        _context.Update(actionItem);
                        _context.SaveChanges();
                        transaction.Commit();
                    }
                    return View();
                }
                catch
                {
                    transaction.Rollback();
                    return View();
                }
            }
        }

        // POST: ActionItems/Delete/5
        [HttpDelete]
        [Route("api/ActionItems/Delete")]
        public ActionResult Delete(int id)
        {
            using (DbContextTransaction transaction = (DbContextTransaction)_context.Database.BeginTransaction())
            {
                try
                {
                    var actionItem = _context.ActionitemActs.FirstOrDefault(a => a.IdAct == id);
                    if (actionItem == null) return NotFound();

                    _context.ActionitemActs.Remove(actionItem);
                    _context.SaveChanges();
                    transaction.Commit();
                    return View();
                }
                catch
                {
                    transaction.Rollback();
                    return View();
                }
            }
        }
    }
}
