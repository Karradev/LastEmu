using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
	{
		public const short Id = 129;

		public sbyte sellType;

		public HumanOption[] options;

		public override short TypeId
		{
			get
			{
				return 129;
			}
		}

		public GameRolePlayMerchantInformations()
		{
		}

		public GameRolePlayMerchantInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, string name, sbyte sellType, HumanOption[] options) : base(contextualId, look, disposition, name)
		{
			this.sellType = sellType;
			this.options = options;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.sellType = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.options = new HumanOption[num];
			for (int i = 0; i < num; i++)
			{
				this.options[i] = ProtocolTypeManager.GetInstance<HumanOption>(reader.ReadUShort());
				this.options[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.sellType);
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