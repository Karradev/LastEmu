using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChallengeTargetUpdateMessage : NetworkMessage
	{
		public const uint Id = 6123;

		public uint challengeId;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6123;
			}
		}

		public ChallengeTargetUpdateMessage()
		{
		}

		public ChallengeTargetUpdateMessage(uint challengeId, double targetId)
		{
			this.challengeId = challengeId;
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.challengeId = reader.ReadVarUhShort();
			this.targetId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.challengeId);
			writer.WriteDouble(this.targetId);
		}
	}
}