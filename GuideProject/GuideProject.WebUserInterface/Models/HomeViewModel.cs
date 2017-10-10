using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuideProject.WebUserInterface.Models
{
    public class HomeViewModel
    {
        public ICollection<Persons> Person { get; set; }
        public List<Addresses> Address { get; set; }
    }
}