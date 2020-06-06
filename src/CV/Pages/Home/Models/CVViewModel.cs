namespace CV.Pages.Home.Models
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

    public class TimelineViewModel
    {
        public EventViewModel[] Events { get; set; }
    }

    public class EventViewModel
    {
        public string Name { get; set; }
        public string Supplement { get; set; }
        public IconInfoViewModel[] IconInfos { get; set; }
        public string Description { get; set; }
        public int From { get; set; }
        public int? To { get; set; }
    }

    public class IconInfoViewModel
    {
        public string Label { get; set; }
        public string Icon { get; set; }
    }
}
