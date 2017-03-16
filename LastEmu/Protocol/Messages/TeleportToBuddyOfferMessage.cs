using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportToBuddyOfferMessage : NetworkMessage
	{
		public const uint Id = 6287;

		public uint dungeonId;

		public double buddyId;

		public uint timeLeft;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6287;
			}
		}

		public TeleportToBuddyOfferMessage()
		{
		}

		public TeleportToBuddyOfferMessage(uint dungeonId, double buddyId, uint timeLeft)
		{
			this.dungeonId = dungeonId;
			this.buddyId = buddyId;
			this.timeLeft = timeLeft;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			this.buddyId = reader.ReadVarUhLong();
			this.timeLeft = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteVarLong(this.buddyId);
			writer.WriteVarInt((int)this.timeLeft);
		}
	}
}