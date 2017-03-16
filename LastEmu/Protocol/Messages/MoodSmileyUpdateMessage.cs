using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MoodSmileyUpdateMessage : NetworkMessage
	{
		public const uint Id = 6388;

		public int accountId;

		public double playerId;

		public uint smileyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6388;
			}
		}

		public MoodSmileyUpdateMessage()
		{
		}

		public MoodSmileyUpdateMessage(int accountId, double playerId, uint smileyId)
		{
			this.accountId = accountId;
			this.playerId = playerId;
			this.smileyId = smileyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.accountId = reader.ReadInt();
			this.playerId = reader.ReadVarUhLong();
			this.smileyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.accountId);
			writer.WriteVarLong(this.playerId);
			writer.WriteVarShort((int)this.smileyId);
		}
	}
}