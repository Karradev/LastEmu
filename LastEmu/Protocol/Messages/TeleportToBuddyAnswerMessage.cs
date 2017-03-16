using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportToBuddyAnswerMessage : NetworkMessage
	{
		public const uint Id = 6293;

		public uint dungeonId;

		public double buddyId;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6293;
			}
		}

		public TeleportToBuddyAnswerMessage()
		{
		}

		public TeleportToBuddyAnswerMessage(uint dungeonId, double buddyId, bool accept)
		{
			this.dungeonId = dungeonId;
			this.buddyId = buddyId;
			this.accept = accept;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			this.buddyId = reader.ReadVarUhLong();
			this.accept = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteVarLong(this.buddyId);
			writer.WriteBoolean(this.accept);
		}
	}
}