using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    //Her class bir tabloya denk geliyor Codefirst Metodu
    public class Anasayfa
    {
        [Key]//Birincil anahtar için
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}