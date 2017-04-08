using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vanhack.Data;
using Vanhack.DTO;
using Vanhack.Models;

namespace Vanhack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                using (var context = new VhDbContext())
                {
                    var listOfJobs = context.JobModel.Include("company").ToList();
                    var newJobList = new List<JobDTO>();

                    foreach (var job in listOfJobs)
                    {
                        var princialSkill = context.Skill.Find(job.PrincipalSkill).SkillName;

                        newJobList.Add(new JobDTO
                        {
                            CityCountry = job.City + ", " + job.Country,
                            CompanyName = job.Company.Name,
                            Id = job.Id,
                            Position = job.Position,
                            PrincipalSkill = princialSkill,
                            Published = job.PostDate
                        });
                    }


                    ViewBag.ListOfJobs = newJobList.ToList();
                }

                return View();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        public ActionResult JobView(int jobId)
        {
            try
            {
                using (var context = new VhDbContext())
                {
                    var princialSkill = "";
                    var job = context.JobModel.Find(jobId);
                    var listOfUsersWithPricinpalSkill = new List<ListUserPrincipalSkillDTO>();

                    var peopleWhithPrincipalSkills = context.UserSkill.Where(c => c.SkillId == job.PrincipalSkill
                                                                                && c.YeatsOfExperience == job.YearOfExperience
                                                                                ).ToList();

                    var findPosition = context.User.Where(c => c.Position == job.Position).ToList();

                    var companyName = context.Company.Find(job.CompanyId).Name;

                    foreach (var user in peopleWhithPrincipalSkills)
                    {
                        var _user = context.User.Find(user.UserId);

                        princialSkill = context.Skill.Find(job.PrincipalSkill).SkillName;

                        listOfUsersWithPricinpalSkill.Add(new ListUserPrincipalSkillDTO
                        {
                            EnglishLevel = _user.EnglishLevel,
                            FirstName = _user.FirstName,
                            LastName = _user.LastName,
                            Position = _user.Position,
                            UserId = _user.Id,
                            YearsOfExprience = _user.YearsOfExperience,
                            Email = _user.Email,
                            PricinpalSkill = princialSkill,
                        });
                    }

                    foreach (var _user in findPosition)
                    {
                        listOfUsersWithPricinpalSkill.Add(new ListUserPrincipalSkillDTO
                        {
                            EnglishLevel = _user.EnglishLevel,
                            FirstName = _user.FirstName,
                            LastName = _user.LastName,
                            Position = _user.Position,
                            UserId = _user.Id,
                            YearsOfExprience = _user.YearsOfExperience,
                            Email = _user.Email,
                            PricinpalSkill = princialSkill,
                        });
                    }

                    ViewBag.ListOfUsers = listOfUsersWithPricinpalSkill.ToList();
                    ViewBag.Job = job;
                    ViewBag.CompanyName = companyName;
                    ViewBag.PrincipalSkill = princialSkill;
                }

                return View();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public ActionResult UserList()
        {
            try
            {
                using (var context = new VhDbContext())
                {
                    var listOfUsers = context.User.ToList();
                    var newUserList = new List<UserDTO>();

                    foreach (var user in listOfUsers)
                    {
                        //var princialSkill = context.Skill.Find(user.PrincipalSkill);

                        newUserList.Add(new UserDTO
                        {
                            Email = user.Email,
                            EnglishLevel = user.EnglishLevel,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Id = user.Id,
                            Linkedin = user.Linkedin,
                            Position = user.Position,
                            Skills  = user.Skills,
                            YearsOfExperience = user.YearsOfExperience
                        });
                    }


                    ViewBag.ListOfUser = newUserList.ToList();
                }

                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ActionResult UserView(int userId)
        {
            using (var context = new VhDbContext())
            {
                var listJob = new List<JobDTO>();
                var user = context.User.Find(userId);
                var jobForUserPosition = context.JobModel.Where(c => c.Position == user.Position).ToList();

                var jobForPrinciipalSkill = context.JobModel.Where(c => c.PrincipalSkill == user.PrincipalSkill).ToList();


                foreach (var job in jobForUserPosition)
                {
                    var princialSkill = context.Skill.Find(job.PrincipalSkill).SkillName;

                    listJob.Add(new JobDTO
                    {
                        CityCountry = job.City + ", " + job.Country,
                        CompanyName = job.Company.Name,
                        Id = job.Id,
                        Position = job.Position,
                        PrincipalSkill = princialSkill,
                        Published = job.PostDate
                    });
                }

                foreach (var job in jobForPrinciipalSkill)
                {
                    var princialSkill = context.Skill.Find(job.PrincipalSkill).SkillName;

                    listJob.Add(new JobDTO
                    {
                        CityCountry = job.City + ", " + job.Country,
                        CompanyName = job.Company.Name,
                        Id = job.Id,
                        Position = job.Position,
                        PrincipalSkill = princialSkill,
                        Published = job.PostDate
                    });
                }

                ViewBag.ListOfJobs = listJob.ToList();
                ViewBag.User = user;
                //ViewBag.CompanyName = companyName;
                //ViewBag.PrincipalSkill = princialSkill;
            }

            return View();
        }

    }
}