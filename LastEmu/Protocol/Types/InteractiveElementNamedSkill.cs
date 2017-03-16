using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class InteractiveElementNamedSkill : InteractiveElementSkill
	{
		public const short Id = 220;

		public uint nameId;

		public override short TypeId
		{
			get
			{
				return 220;
			}
		}

		public InteractiveElementNamedSkill()
		{
		}

		public InteractiveElementNamedSkill(uint skillId, int skillInstanceUid, uint nameId) : base(skillId, skillInstanceUid)
		{
			this.nameId = nameId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.nameId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.nameId);
		}
	}
}