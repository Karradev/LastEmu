using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HavenBagFurnituresRequestMessage : NetworkMessage
	{
		public const uint Id = 6637;

		public uint[] cellIds;

		public int[] funitureIds;

		public sbyte[] orientations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6637;
			}
		}

		public HavenBagFurnituresRequestMessage()
		{
		}

		public HavenBagFurnituresRequestMessage(uint[] cellIds, int[] funitureIds, sbyte[] orientations)
		{
			this.cellIds = cellIds;
			this.funitureIds = funitureIds;
			this.orientations = orientations;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.cellIds = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.cellIds[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.funitureIds = new int[num];
			for (int j = 0; j < num; j++)
			{
				this.funitureIds[j] = reader.ReadInt();
			}
			num = (ushort)reader.ReadVarInt();
			this.orientations = new sbyte[num];
			for (int k = 0; k < num; k++)
			{
				this.orientations[k] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.cellIds.Length));
			uint[] numArray = this.cellIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.funitureIds.Length));
			int[] numArray1 = this.funitureIds;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteInt(numArray1[j]);
			}
			writer.WriteVarInt((int)((int)this.orientations.Length));
			sbyte[] numArray2 = this.orientations;
			for (int k = 0; k < (int)numArray2.Length; k++)
			{
				writer.WriteSByte(numArray2[k]);
			}
		}
	}
}