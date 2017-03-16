using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightShowFighterRandomStaticPoseMessage : GameFightShowFighterMessage
	{
		public const uint Id = 6218;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6218;
			}
		}

		public GameFightShowFighterRandomStaticPoseMessage()
		{
		}

		public GameFightShowFighterRandomStaticPoseMessage(GameFightFighterInformations informations) : base(informations)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}