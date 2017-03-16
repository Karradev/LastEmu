using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightDispellableEffectExtendedInformations
	{
		public const short Id = 208;

		public uint actionId;

		public double sourceId;

		public AbstractFightDispellableEffect effect;

		public virtual short TypeId
		{
			get
			{
				return 208;
			}
		}

		public FightDispellableEffectExtendedInformations()
		{
		}

		public FightDispellableEffectExtendedInformations(uint actionId, double sourceId, AbstractFightDispellableEffect effect)
		{
			this.actionId = actionId;
			this.sourceId = sourceId;
			this.effect = effect;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.actionId = reader.ReadVarUhShort();
			this.sourceId = reader.ReadDouble();
			this.effect = ProtocolTypeManager.GetInstance<AbstractFightDispellableEffect>(reader.ReadUShort());
			this.effect.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.actionId);
			writer.WriteDouble(this.sourceId);
			writer.WriteShort(this.effect.TypeId);
			this.effect.Serialize(writer);
		}
	}
}