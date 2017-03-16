using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareCanceledMessage : NetworkMessage
	{
		public const uint Id = 6679;

		public double dareId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6679;
			}
		}

		public DareCanceledMessage()
		{
		}

		public DareCanceledMessage(double dareId)
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