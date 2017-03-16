using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
	{
		public const uint Id = 5669;

		public int mapId;

		public uint elementId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5669;
			}
		}

		public LockableStateUpdateStorageMessage()
		{
		}

		public LockableStateUpdateStorageMessage(bool locked, int mapId, uint elementId) : base(locked)
		{
			this.mapId = mapId;
			this.elementId = elementId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.mapId = reader.ReadInt();
			this.elementId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.mapId);
			writer.WriteVarInt((int)this.elementId);
		}
	}
}