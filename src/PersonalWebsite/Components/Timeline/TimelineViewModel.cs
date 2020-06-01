using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Components.Timeline
{
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
