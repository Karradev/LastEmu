using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryPresetSaveCustomMessage : NetworkMessage
	{
		public const uint Id = 6329;

		public sbyte presetId;

		public sbyte symbolId;

		public byte[] itemsPositions;

		public uint[] itemsUids;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6329;
			}
		}

		public InventoryPresetSaveCustomMessage()
		{
		}

		public InventoryPresetSaveCustomMessage(sbyte presetId, sbyte symbolId, byte[] itemsPositions, uint[] itemsUids)
		{
			this.presetId = presetId;
			this.symbolId = symbolId;
			this.itemsPositions = itemsPositions;
			this.itemsUids = itemsUids;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.symbolId = reader.ReadSByte();
			ushort num = (ushort)reader.ReadVarInt();
			this.itemsPositions = new byte[num];
			for (int i = 0; i < num; i++)
			{
				this.itemsPositions[i] = reader.ReadByte();
			}
			num = reader.ReadUShort();
			this.itemsUids = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.itemsUids[j] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.symbolId);
			writer.WriteVarInt((int)((int)this.itemsPositions.Length));
			byte[] numArray = this.itemsPositions;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteByte(numArray[i]);
			}
			writer.WriteShort((short)((int)this.itemsUids.Length));
			uint[] numArray1 = this.itemsUids;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarInt((int)numArray1[j]);
			}
		}
	}
}