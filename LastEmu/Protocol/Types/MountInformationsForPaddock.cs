using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MountInformationsForPaddock
	{
		public const short Id = 184;

		public uint modelId;

		public string name;

		public string ownerName;

		public virtual short TypeId
		{
			get
			{
				return 184;
			}
		}

		public MountInformationsForPaddock()
		{
		}

		public MountInformationsForPaddock(uint modelId, string name, string ownerName)
		{
			this.modelId = modelId;
			this.name = name;
			this.ownerName = ownerName;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.modelId = reader.ReadVarUhShort();
			this.name = reader.ReadUTF();
			this.ownerName = reader.ReadUTF();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.modelId);
			writer.WriteUTF(this.name);
			writer.WriteUTF(this.ownerName);
		}
	}
}