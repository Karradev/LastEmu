using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameActionFightDispellableEffectMessage : AbstractGameActionMessage
	{
		public const uint Id = 6070;

		public AbstractFightDispellableEffect effect;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6070;
			}
		}

		public GameActionFightDispellableEffectMessage()
		{
		}

		public GameActionFightDispellableEffectMessage(uint actionId, double sourceId, AbstractFightDispellableEffect effect) : base(actionId, sourceId)
		{
			this.effect = effect;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.effect = ProtocolTypeManager.GetInstance<AbstractFightDispellableEffect>(reader.ReadUShort());
			this.effect.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.effect.TypeId);
			this.effect.Serialize(writer);
		}
	}
}