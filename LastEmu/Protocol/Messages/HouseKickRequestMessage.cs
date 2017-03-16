using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseKickRequestMessage : NetworkMessage
	{
		public const uint Id = 5698;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5698;
			}
		}

		public HouseKickRequestMessage()
		{
		}

		public HouseKickRequestMessage(double id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.id);
		}
	}
}