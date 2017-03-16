using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemInRolePlay
	{
		public const short Id = 198;

		public uint cellId;

		public uint objectGID;

		public virtual short TypeId
		{
			get
			{
				return 198;
			}
		}

		public ObjectItemInRolePlay()
		{
		}

		public ObjectItemInRolePlay(uint cellId, uint objectGID)
		{
			this.cellId = cellId;
			this.objectGID = objectGID;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
			this.objectGID = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
			writer.WriteVarShort((int)this.objectGID);
		}
	}
}