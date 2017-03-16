using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareRewardsListMessage : NetworkMessage
	{
		public const uint Id = 6677;

		public DareReward[] rewards;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6677;
			}
		}

		public DareRewardsListMessage()
		{
		}

		public DareRewardsListMessage(DareReward[] rewards)
		{
			this.rewards = rewards;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.rewards = new DareReward[num];
			for (int i = 0; i < num; i++)
			{
				this.rewards[i] = new DareReward();
				this.rewards[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.rewards.Length));
			DareReward[] dareRewardArray = this.rewards;
			for (int i = 0; i < (int)dareRewardArray.Length; i++)
			{
				dareRewardArray[i].Serialize(writer);
			}
		}
	}
}