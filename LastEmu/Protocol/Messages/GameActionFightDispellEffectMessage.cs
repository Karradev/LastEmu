using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
	{
		public const uint Id = 6113;

		public int boostUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6113;
			}
		}

		public GameActionFightDispellEffectMessage()
		{
		}

		public GameActionFightDispellEffectMessage(uint actionId, double sourceId, double targetId, int boostUID) : base(actionId, sourceId, targetId)
		{
			this.boostUID = boostUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.boostUID = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.boostUID);
		}
	}
}