using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
	{
		public const uint Id = 6557;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6557;
			}
		}

		public ExchangeMountsStableBornAddMessage()
		{
		}

		public ExchangeMountsStableBornAddMessage(MountClientData[] mountDescription) : base(mountDescription)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}