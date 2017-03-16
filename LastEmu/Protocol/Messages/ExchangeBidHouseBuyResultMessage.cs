using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseBuyResultMessage : NetworkMessage
	{
		public const uint Id = 6272;

		public uint uid;

		public bool bought;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6272;
			}
		}

		public ExchangeBidHouseBuyResultMessage()
		{
		}

		public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
		{
			this.uid = uid;
			this.bought = bought;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadVarUhInt();
			this.bought = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.uid);
			writer.WriteBoolean(this.bought);
		}
	}
}