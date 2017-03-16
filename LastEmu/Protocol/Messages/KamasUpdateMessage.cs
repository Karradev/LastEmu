using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KamasUpdateMessage : NetworkMessage
	{
		public const uint Id = 5537;

		public int kamasTotal;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5537;
			}
		}

		public KamasUpdateMessage()
		{
		}

		public KamasUpdateMessage(int kamasTotal)
		{
			this.kamasTotal = kamasTotal;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.kamasTotal = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.kamasTotal);
		}
	}
}