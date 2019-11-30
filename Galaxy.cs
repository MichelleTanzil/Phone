using System;
namespace phone
{
    class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return $"... {RingTone} ...";
        }

        public string Unlock() 
        {
            return $"Galaxy {VersionNumber} unlocked with passcode";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("###################");
            Console.WriteLine($"Nokia {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine("###################");
        }
    }
}