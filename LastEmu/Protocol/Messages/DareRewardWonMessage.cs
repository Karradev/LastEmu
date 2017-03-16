using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareRewardWonMessage : NetworkMessage
	{
		public const uint Id = 6678;

		public DareReward reward;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6678;
			}
		}

		public DareRewardWonMessage()
		{
		}

		public DareRewardWonMessage(DareReward reward)
		{
			this.reward = reward;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reward = new DareReward();
			this.reward.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.reward.Serialize(writer);
		}
	}
}