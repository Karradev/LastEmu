using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
	{
		public const uint Id = 6176;

		public uint spellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6176;
			}
		}

		public GameActionFightDispellSpellMessage()
		{
		}

		public GameActionFightDispellSpellMessage(uint actionId, double sourceId, double targetId, uint spellId) : base(actionId, sourceId, targetId)
		{
			this.spellId = spellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.spellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.spellId);
		}
	}
}