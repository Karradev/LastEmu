using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightTriggerEffectMessage : GameActionFightDispellEffectMessage
	{
		public const uint Id = 6147;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6147;
			}
		}

		public GameActionFightTriggerEffectMessage()
		{
		}

		public GameActionFightTriggerEffectMessage(uint actionId, double sourceId, double targetId, int boostUID) : base(actionId, sourceId, targetId, boostUID)
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