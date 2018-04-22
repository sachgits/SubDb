using System;
using MediaBrowser.Common.Plugins;

namespace SubDb
{
    public class Plugin : BasePlugin
    {
        private Guid _id = new Guid("F015EA06-B413-47F1-BF15-F049A799658B");
        public override Guid Id
        {
            get { return _id; }
        }

        public override string Name
        {
            get { return StaticName; }
        }

        public static string StaticName
        {
            get { return "SubDb"; }
        }

        public override string Description
        {
            get
            {
                return "Download subtitles from Subdb";
            }
        }
    }
}
