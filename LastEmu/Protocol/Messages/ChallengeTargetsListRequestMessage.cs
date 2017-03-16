using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChallengeTargetsListRequestMessage : NetworkMessage
	{
		public const uint Id = 5614;

		public uint challengeId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5614;
			}
		}

		public ChallengeTargetsListRequestMessage()
		{
		}

		public ChallengeTargetsListRequestMessage(uint challengeId)
		{
			this.challengeId = challengeId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.challengeId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.challengeId);
		}
	}
}