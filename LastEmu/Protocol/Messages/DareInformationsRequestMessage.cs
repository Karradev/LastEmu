using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareInformationsRequestMessage : NetworkMessage
	{
		public const uint Id = 6659;

		public double dareId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6659;
			}
		}

		public DareInformationsRequestMessage()
		{
		}

		public DareInformationsRequestMessage(double dareId)
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