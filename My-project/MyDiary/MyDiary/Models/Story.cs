using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDiary.Models
{
    public class Story
    {
        [Key]
        public int StoryId { get;  set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Story")]
        public string Name { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfCreate { get; set; }

        [Range (1, 5, ErrorMessage = "Rate must be between 1 and 5")]
        public int Rate { get; set; }

        [Required(ErrorMessage = "Text is required")]
        [AllowHtml]
        [DataType("tinymce_full")]
        public string Text { get; set; }

        public byte[] Picture { get; set; }
    }
}