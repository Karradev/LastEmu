using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryPresetItemUpdateRequestMessage : NetworkMessage
	{
		public const uint Id = 6210;

		public sbyte presetId;

		public byte position;

		public uint objUid;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6210;
			}
		}

		public InventoryPresetItemUpdateRequestMessage()
		{
		}

		public InventoryPresetItemUpdateRequestMessage(sbyte presetId, byte position, uint objUid)
		{
			this.presetId = presetId;
			this.position = position;
			this.objUid = objUid;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.position = reader.ReadByte();
			this.objUid = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteByte(this.position);
			writer.WriteVarInt((int)this.objUid);
		}
	}
}