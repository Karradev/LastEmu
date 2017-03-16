using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
	{
		public const uint Id = 6425;

		public uint objectGID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6425;
			}
		}

		public GameRolePlayDelayedObjectUseMessage()
		{
		}

		public GameRolePlayDelayedObjectUseMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime, uint objectGID) : base(delayedCharacterId, delayTypeId, delayEndTime)
		{
			this.objectGID = objectGID;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectGID = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.objectGID);
		}
	}
}