using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareWonMessage : NetworkMessage
	{
		public const uint Id = 6681;

		public double dareId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6681;
			}
		}

		public DareWonMessage()
		{
		}

		public DareWonMessage(double dareId)
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