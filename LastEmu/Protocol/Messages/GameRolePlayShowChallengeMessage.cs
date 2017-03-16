using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameRolePlayShowChallengeMessage : NetworkMessage
	{
		public const uint Id = 301;

		public FightCommonInformations commonsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)301;
			}
		}

		public GameRolePlayShowChallengeMessage()
		{
		}

		public GameRolePlayShowChallengeMessage(FightCommonInformations commonsInfos)
		{
			this.commonsInfos = commonsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.commonsInfos = new FightCommonInformations();
			this.commonsInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.commonsInfos.Serialize(writer);
		}
	}
}