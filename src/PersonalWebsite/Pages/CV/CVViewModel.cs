using PersonalWebsite.Components.CV.Skill;
using PersonalWebsite.Components.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Pages.CV
{
    public class CVViewModel
    {
        public string Name { get; set; }
        public string JobPosition { get; set; }
        public string Picture { get; set; }
        public string Aboutme { get; set; }
        public ContactViewModel[] Contacts { get; set; }
        public SkillViewModel[] Skills { get; set; }
        public TimelineViewModel Experience { get; set; }
        public TimelineViewModel Education { get; set; }
        public HobbiesViewModel[] Hobbies { get; set; }
    }

    public class ContactViewModel
    {
        public string Link { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
    }

    public class SkillViewModel
    {
        public string Label { get; set; }
        public int Percentage { get; set; }
    }

    public class HobbiesViewModel
    {
        public string Label { get; set; }
        public string Icon { get; set; }
    }
}
