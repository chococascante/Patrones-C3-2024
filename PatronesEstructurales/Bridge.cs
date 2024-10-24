using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
    public interface IDevice
    {
        void TurnOn();
    }

    public class TV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Encendiendo TV");
        }
    }

    public abstract class Remote
    {
        protected IDevice _device;

        protected Remote(IDevice device)
        {
            _device = device;
        }

        public abstract void TurnOn();
    }

    public class RemoteControl : Remote
    {
        public RemoteControl(IDevice device) : base(device)
        {
        }

        public override void TurnOn()
        {
            _device.TurnOn();
        }
    }
}
