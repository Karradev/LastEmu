using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
	{
		public const uint Id = 5668;

		public uint houseId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5668;
			}
		}

		public LockableStateUpdateHouseDoorMessage()
		{
		}

		public LockableStateUpdateHouseDoorMessage(bool locked, uint houseId) : base(locked)
		{
			this.houseId = houseId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.houseId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.houseId);
		}
	}
}