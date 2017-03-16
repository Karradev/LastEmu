using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportToBuddyCloseMessage : NetworkMessage
	{
		public const uint Id = 6303;

		public uint dungeonId;

		public double buddyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6303;
			}
		}

		public TeleportToBuddyCloseMessage()
		{
		}

		public TeleportToBuddyCloseMessage(uint dungeonId, double buddyId)
		{
			this.dungeonId = dungeonId;
			this.buddyId = buddyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			this.buddyId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteVarLong(this.buddyId);
		}
	}
}