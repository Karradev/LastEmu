using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class InteractiveElementSkill
	{
		public const short Id = 219;

		public uint skillId;

		public int skillInstanceUid;

		public virtual short TypeId
		{
			get
			{
				return 219;
			}
		}

		public InteractiveElementSkill()
		{
		}

		public InteractiveElementSkill(uint skillId, int skillInstanceUid)
		{
			this.skillId = skillId;
			this.skillInstanceUid = skillInstanceUid;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.skillId = reader.ReadVarUhInt();
			this.skillInstanceUid = reader.ReadInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.skillId);
			writer.WriteInt(this.skillInstanceUid);
		}
	}
}