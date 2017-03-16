using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareCancelRequestMessage : NetworkMessage
	{
		public const uint Id = 6680;

		public double dareId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6680;
			}
		}

		public DareCancelRequestMessage()
		{
		}

		public DareCancelRequestMessage(double dareId)
		{
			this.dareId = dareId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dareId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.dareId);
		}
	}
}