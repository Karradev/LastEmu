using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryPresetUseResultMessage : NetworkMessage
	{
		public const uint Id = 6163;

		public sbyte presetId;

		public sbyte code;

		public byte[] unlinkedPosition;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6163;
			}
		}

		public InventoryPresetUseResultMessage()
		{
		}

		public InventoryPresetUseResultMessage(sbyte presetId, sbyte code, byte[] unlinkedPosition)
		{
			this.presetId = presetId;
			this.code = code;
			this.unlinkedPosition = unlinkedPosition;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.code = reader.ReadSByte();
			ushort num = (ushort)reader.ReadVarInt();
			this.unlinkedPosition = new byte[num];
			for (int i = 0; i < num; i++)
			{
				this.unlinkedPosition[i] = reader.ReadByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.code);
			writer.WriteVarInt((int)((int)this.unlinkedPosition.Length));
			byte[] numArray = this.unlinkedPosition;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteByte(numArray[i]);
			}
		}
	}
}