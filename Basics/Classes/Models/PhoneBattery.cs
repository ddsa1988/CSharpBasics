using Basics.Classes.Enums;

namespace Basics.Classes.Models;

public class PhoneBattery {
    public string Model { get; set; }
    public BatteryType BatteryType { get; set; }
    public TimeSpan IdleTime { get; private set; }
    public TimeSpan HoursTalk { get; private set; }

    public PhoneBattery() : this(string.Empty) { }

    public PhoneBattery(string mode) {
        Model = mode;
    }

    public PhoneBattery(string model, double idleTime, double hoursTalk, BatteryType batteryType) : this(model) {
        SetIdleTime(idleTime);
        SetHoursTalk(hoursTalk);
        BatteryType = batteryType;
    }

    public void SetIdleTime(double minutes) {
        if (minutes <= 0) {
            throw new ArgumentOutOfRangeException(nameof(minutes), "Parameter must be greater tna zero.");
        }

        IdleTime = TimeSpan.FromMinutes(minutes);
    }

    public void SetHoursTalk(double minutes) {
        if (minutes <= 0) {
            throw new ArgumentOutOfRangeException(nameof(minutes), "Parameter must be greater tna zero.");
        }

        HoursTalk = TimeSpan.FromMinutes(minutes);
    }
}