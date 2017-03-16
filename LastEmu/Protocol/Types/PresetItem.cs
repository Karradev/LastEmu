using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PresetItem
	{
		public const short Id = 354;

		public byte position;

		public uint objGid;

		public uint objUid;

		public virtual short TypeId
		{
			get
			{
				return 354;
			}
		}

		public PresetItem()
		{
		}

		public PresetItem(byte position, uint objGid, uint objUid)
		{
			this.position = position;
			this.objGid = objGid;
			this.objUid = objUid;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.position = reader.ReadByte();
			this.objGid = reader.ReadVarUhShort();
			this.objUid = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.position);
			writer.WriteVarShort((int)this.objGid);
			writer.WriteVarInt((int)this.objUid);
		}
	}
}