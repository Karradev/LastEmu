using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChallengeInfoMessage : NetworkMessage
	{
		public const uint Id = 6022;

		public uint challengeId;

		public double targetId;

		public uint xpBonus;

		public uint dropBonus;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6022;
			}
		}

		public ChallengeInfoMessage()
		{
		}

		public ChallengeInfoMessage(uint challengeId, double targetId, uint xpBonus, uint dropBonus)
		{
			this.challengeId = challengeId;
			this.targetId = targetId;
			this.xpBonus = xpBonus;
			this.dropBonus = dropBonus;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.challengeId = reader.ReadVarUhShort();
			this.targetId = reader.ReadDouble();
			this.xpBonus = reader.ReadVarUhInt();
			this.dropBonus = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.challengeId);
			writer.WriteDouble(this.targetId);
			writer.WriteVarInt((int)this.xpBonus);
			writer.WriteVarInt((int)this.dropBonus);
		}
	}
}