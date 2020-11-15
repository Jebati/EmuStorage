using System;
using System.Collections.Generic;
using System.Text;

namespace EmuStorage
{
    public class DVD : Storage
    {
        private float totalUnilateralKb = 4596992;
        private float speedReadKb = 1352;
        private float speedWriteKb = 1352;
        public DVD(string name, string model, float busyKb, bool unilateral = false) : base(name, model, StorageType.DVD)
        {
            TotalKb = unilateral ? totalUnilateralKb * 2 : totalUnilateralKb;
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
