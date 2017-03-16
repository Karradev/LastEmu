using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChallengeResultMessage : NetworkMessage
	{
		public const uint Id = 6019;

		public uint challengeId;

		public bool success;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6019;
			}
		}

		public ChallengeResultMessage()
		{
		}

		public ChallengeResultMessage(uint challengeId, bool success)
		{
			this.challengeId = challengeId;
			this.success = success;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.challengeId = reader.ReadVarUhShort();
			this.success = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.challengeId);
			writer.WriteBoolean(this.success);
		}
	}
}