using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
	{
		public const uint Id = 6221;

		public double targetId;

		public uint spellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6221;
			}
		}

		public GameActionFightSpellImmunityMessage()
		{
		}

		public GameActionFightSpellImmunityMessage(uint actionId, double sourceId, double targetId, uint spellId) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.spellId = spellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.spellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteVarShort((int)this.spellId);
		}
	}
}