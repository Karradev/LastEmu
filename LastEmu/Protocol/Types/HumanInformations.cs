using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class HumanInformations
	{
		public const short Id = 157;

		public ActorRestrictionsInformations restrictions;

		public bool sex;

		public HumanOption[] options;

		public virtual short TypeId
		{
			get
			{
				return 157;
			}
		}

		public HumanInformations()
		{
		}

		public HumanInformations(ActorRestrictionsInformations restrictions, bool sex, HumanOption[] options)
		{
			this.restrictions = restrictions;
			this.sex = sex;
			this.options = options;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.restrictions = new ActorRestrictionsInformations();
			this.restrictions.Deserialize(reader);
			this.sex = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.options = new HumanOption[num];
			for (int i = 0; i < num; i++)
			{
				this.options[i] = ProtocolTypeManager.GetInstance<HumanOption>(reader.ReadUShort());
				this.options[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			this.restrictions.Serialize(writer);
			writer.WriteBoolean(this.sex);
			writer.WriteShort((short)((int)this.options.Length));
			HumanOption[] humanOptionArray = this.options;
			for (int i = 0; i < (int)humanOptionArray.Length; i++)
			{
				HumanOption humanOption = humanOptionArray[i];
				writer.WriteShort(humanOption.TypeId);
				humanOption.Serialize(writer);
			}
		}
	}
}