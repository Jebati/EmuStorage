using System;
using System.Collections.Generic;
using System.Text;

namespace EmuStorage
{
    public class PocketHDD : Storage
    {
        public PocketHDD(string name, string model, float busyKb, int sectors, float sectorKb, float usbReadSpeed, float usbWriteSpeed) : base(name, model, StorageType.PocketHDD)
        {
            BusyKb = busyKb;
            TotalKb = sectors * sectorKb;
            SpeedReadKb = usbReadSpeed;
            SpeedWriteKb = usbWriteSpeed;
        }

        public override string GetUniqueInfo()
        {
            return String.Empty;
        }
    }
}
