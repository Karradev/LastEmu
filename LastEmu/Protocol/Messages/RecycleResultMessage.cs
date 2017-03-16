using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class RecycleResultMessage : NetworkMessage
	{
		public const uint Id = 6601;

		public uint nuggetsForPrism;

		public uint nuggetsForPlayer;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6601;
			}
		}

		public RecycleResultMessage()
		{
		}

		public RecycleResultMessage(uint nuggetsForPrism, uint nuggetsForPlayer)
		{
			this.nuggetsForPrism = nuggetsForPrism;
			this.nuggetsForPlayer = nuggetsForPlayer;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.nuggetsForPrism = reader.ReadVarUhInt();
			this.nuggetsForPlayer = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.nuggetsForPrism);
			writer.WriteVarInt((int)this.nuggetsForPlayer);
		}
	}
}