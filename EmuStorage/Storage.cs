using System;
using System.Collections.Generic;
using System.Text;

namespace EmuStorage
{
    public abstract class Storage
    {
        public StorageType Type { get; private set; } = StorageType.PocketHDD;
        public string Name { get; private set; } = String.Empty;
        public string Model { get; private set; } = String.Empty;
        public float TotalKb { get; set; } = 0;
        public float BusyKb { get; set; } = 0;
        public float SpeedReadKb { get; set; } = 0;
        public float SpeedWriteKb { get; set; } = 0;

        public Storage() { }
        public Storage(string name, string model, StorageType type)
        {
            Name = name;
            Model = model;
            Type = type;
        }
        public string GetInfo()
        {
            return $"[{Type.ToString()}]: {Name} - {Model}\n" +
                $"\tTotal, mb: {TotalKb / 1024}\n" +
                $"\tBusy, mb: {BusyKb / 1024}\n" +
                $"\tSpeed read, mb/s: {SpeedReadKb / 1024}\n" +
                $"\tSpeed write, mb/s: {SpeedWriteKb / 1024}\n" +
                GetUniqueInfo();
        }
        public abstract string GetUniqueInfo();
        public static ResultCopy Copy(Storage source, Storage destination)
        {
            float freeKb = destination.TotalKb - destination.BusyKb;
            float speedWriteKb = destination.SpeedWriteKb;
            if (freeKb < source.BusyKb)
            {
                return ResultCopy.NotEnoughStorage;
            }

            destination.BusyKb += source.BusyKb;

            return ResultCopy.Ok;
        }
    }
}
