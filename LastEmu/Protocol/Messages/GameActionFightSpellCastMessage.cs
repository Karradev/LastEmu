using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
	{
		public const uint Id = 1010;

		public uint spellId;

		public short spellLevel;

		public short[] portalsIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1010;
			}
		}

		public GameActionFightSpellCastMessage()
		{
		}

		public GameActionFightSpellCastMessage(uint actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, uint spellId, short spellLevel, short[] portalsIds) : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
		{
			this.spellId = spellId;
			this.spellLevel = spellLevel;
			this.portalsIds = portalsIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.spellId = reader.ReadVarUhShort();
			this.spellLevel = reader.ReadShort();
			ushort num = reader.ReadUShort();
			this.portalsIds = new short[num];
			for (int i = 0; i < num; i++)
			{
				this.portalsIds[i] = reader.ReadShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.spellId);
			writer.WriteShort(this.spellLevel);
			writer.WriteShort((short)((int)this.portalsIds.Length));
			short[] numArray = this.portalsIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteShort(numArray[i]);
			}
		}
	}
}