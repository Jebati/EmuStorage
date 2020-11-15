using System;
using System.Collections.Generic;
using System.Text;

namespace EmuStorage
{
    public class Flash : Storage
    {
        public Flash(string name, string model, float totalKb, float busyKb, float speedReadKb, float speedWriteKb) : base(name, model, StorageType.Flash)
        {
            TotalKb = totalKb;
            BusyKb = busyKb;
            SpeedReadKb = speedReadKb;
            SpeedWriteKb = speedWriteKb;
        }

        public override string GetUniqueInfo()
        {
            return String.Empty;
        }
    }
}
