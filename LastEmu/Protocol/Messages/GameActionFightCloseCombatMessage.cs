using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
	{
		public const uint Id = 6116;

		public uint weaponGenericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6116;
			}
		}

		public GameActionFightCloseCombatMessage()
		{
		}

		public GameActionFightCloseCombatMessage(uint actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, uint weaponGenericId) : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
		{
			this.weaponGenericId = weaponGenericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.weaponGenericId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.weaponGenericId);
		}
	}
}